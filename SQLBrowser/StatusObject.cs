using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBrowser
{
    public enum StatusCode
    {
        SUCCESS,
        FAILURE
    }
    public class StatusObject
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorStackTrace { get; set; }
        public StatusCode Status { get; set; }
        public dynamic UDDynamic { get; set; }
        public StatusObject()
        {
            this.Status = StatusCode.SUCCESS;
        }
        public StatusObject(string ErrorCode, string ErrorMessage, string ErrorStacktrace, StatusCode Status, dynamic UDDynamic)
        {
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.ErrorStackTrace = ErrorStackTrace;
            this.Status = Status;
            this.UDDynamic = UDDynamic;
        }
    }
}
