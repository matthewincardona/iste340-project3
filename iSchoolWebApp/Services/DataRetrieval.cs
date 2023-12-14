using System.Net.Http.Headers;

namespace iSchoolWebApp.Services
{
    public class DataRetrieval
    {
        /*
         * Task vs Thread
         * Task has async/await and can return a value
         * Task can do multiple things at once, thread can do one
         * can cancel a task
         * Task is a higher level concept than a thread
         */
        //use - GetData("about/")
        public async Task<string> GetData(string endpoint)
        {
            //using is interesting - at the end of the statement it is automatically disposed of
            using(var client = new HttpClient())
            {
                //set up the base
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/"); 
                //clean it up
                client.DefaultRequestHeaders.Accept.Clear();
                //set the type
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    //get ready to send off
                    HttpResponseMessage response = 
                        await client.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead);  
                    response.EnsureSuccessStatusCode();
                    //we can actually go get it...
                    var data = await response.Content.ReadAsStringAsync();
                    //data is just a big string...
                    return data;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    return "HttpRequest: " + msg;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    return "Ex: " + msg;
                }
             }
        }
    }
}





