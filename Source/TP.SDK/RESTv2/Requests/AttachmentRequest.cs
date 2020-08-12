using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.SDK.RESTv2.Requests
{
    public class AttachmentRequest : IRequest
    {
        int Id { get; set; }

        public AttachmentRequest(int id) 
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return $"/Attachment.aspx?AttachmentID={this.Id}";
        }
    }
}
