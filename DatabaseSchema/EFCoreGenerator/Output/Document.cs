using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public partial class Document
    {
        public Document()
        {
            ProductDocument = new HashSet<ProductDocument>();
        }
        public Microsoft.SqlServer.Types.SqlHierarchyId DocumentNode { get; set; }
        public short? DocumentLevel { get; set; }
        public string Title { get; set; }
        public int Owner { get; set; }
        public bool FolderFlag { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string Revision { get; set; }
        public int ChangeNumber { get; set; }
        public byte Status { get; set; }
        public string DocumentSummary { get; set; }
        public byte[] Document1 { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Employee Owner1 { get; set; }
        public virtual ICollection<ProductDocument> ProductDocument { get; set; }
    }
}