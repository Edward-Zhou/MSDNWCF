using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WCFAsyncSelfHost
{
    [ServiceContract]
    public class AsyncService
    {
        //works fine.
        [OperationContract]
        [WebGet(UriTemplate = "GetValue/{word}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        public string GetValue(string word)
        {
            return "HI" + word;
        }

        //doesnt work
        [OperationContract]
        [WebGet(UriTemplate = "AsyncService/GetValueAsync/{word}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        public async Task<string> GetValueAsync(string word)
        {
            //getting compilation error in the below line.
            return await Task.Factory.StartNew(() => { return "HI" + word; });
        }
    }
}
