using CodegenCS.Models;
using CodegenCS;
using NSwag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NJsonSchema;

namespace NSwagClient;

public class NSwagClient
{
    // This is the main method
    public void Main(ICodegenContext context, OpenApiDocument model)
    {
        foreach (var entity in model.Definitions)
        {
            context[$@"Model\{entity.Key.Replace(".", "")}.cs"].WriteLine(GenerateEntity(entity.Key, entity.Value));
        }
    }

    // Visual Studio Extension can be used to run templates (right click template and click "Run Template")
    // But it won't know WHICH MODEL to use. So this is an alternative entrypoint that specified the model path inside it.
    void Main(ICodegenContext context, IModelFactory factory)
    {
        var model = factory.LoadModelFromFile<OpenApiDocument>("MySwagger.json");
        Main(context, model);
    }


    FormattableString GenerateEntity(string modelName, NJsonSchema.JsonSchema schema)
    {
        return $$"""

            using System;
            using System.Text;
            using System.Collections;
            using System.Collections.Generic;
            using System.Runtime.Serialization;
            using Newtonsoft.Json;

            namespace IO.Swagger.Model 
            {

              /// <summary>
              /// 
              /// </summary>
              [DataContract]
              public class {{modelName.Replace(".", "")}} 
              {
                {{schema.Properties.Select(prop => GenerateProperty(prop))}}

                /// <summary>
                /// Get the string presentation of the object
                /// </summary>
                /// <returns>String presentation of the object</returns>
                public override string ToString()  
                {
                  var sb = new StringBuilder();
                  sb.Append("class {{modelName.Replace(".", "")}} {\n");
                  {{schema.Properties.Select(prop => $"sb.Append(\"  {GetPropName(prop.Value)}: \").Append({GetPropName(prop.Value)}).Append(\"\\n\");")}}
                  sb.Append("}\n");
                  return sb.ToString();
                }

                /// <summary>
                /// Get the JSON string presentation of the object
                /// </summary>
                /// <returns>JSON string presentation of the object</returns>
                public string ToJson() 
                {
                  return JsonConvert.SerializeObject(this, Formatting.Indented);
                }

            }
            }
            """;
    }
    FormattableString GenerateProperty(KeyValuePair<string, NJsonSchema.JsonSchemaProperty> prop)
    {
        return $$"""
            /// <summary>
            /// Gets or Sets {{FirstLetterToUpper(prop.Value.Name)}}
            /// </summary>
            [DataMember(Name="{{prop.Value.Name}}", EmitDefaultValue=false)]
            [JsonProperty(PropertyName = "{{prop.Value.Name}}")]
            public {{GetType(prop.Value)}} {{FirstLetterToUpper(prop.Value.Name)}} { get; set; }
            """;
    }
    string GetPropName(NJsonSchema.JsonSchemaProperty property)
    {
        return FirstLetterToUpper(property.Name);
    }
    string FirstLetterToUpper(string str)
    {
        if (str == null)
            return null;

        if (str.Length > 1)
            return char.ToUpper(str[0]) + str.Substring(1);

        return str.ToUpper();
    }
    string GetType(JsonSchemaProperty prop)
    {
        string typeName = prop.Type.ToString();
        //TODO: prop.IsArray, prop.Items.ToList().FirstOrDefault()?.ToString() ?? ""
        if (_typeAlias.ContainsKey(typeName)) return _typeAlias[typeName];
        return typeName;
    }
    private static Dictionary<string, string> _typeAlias = new Dictionary<string, string>
    {
        { "String", "string" },
        { "Integer", "int" },
    };

}
