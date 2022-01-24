using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Domain.Base
{
    public class ResponseBase
    {
        public List<Response> data { get; set; }
    }

    public class Response
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string ProviderConfirmationId { get; set; }
        public List<AssociatedRecords> AssociatedRecords { get; set; }
    }

    public class AssociatedRecords
    {
        public string Reference { get; set; }
        public string OriginSystemCode { get; set; }
    }
}
