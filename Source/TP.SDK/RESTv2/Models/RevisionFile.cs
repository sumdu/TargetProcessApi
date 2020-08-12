using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Models
{
    public class RevisionFile
    {
        // Values
        public int Id { get; set; }
        public string FileName { get; set; }
        public FileActionEnum FileAction { get; set; }

        // Resource references

        public Revision Revision { get; set; }
    }
    public enum FileActionEnum 
    {
        None,
        Add,
        Delete,
        Modify,
        Rename
    }
}
