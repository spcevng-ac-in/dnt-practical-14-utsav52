using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://helloWorld.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    [WebMethod]
    public int add(int x, int y)
    {
        return(x+y);
    }
    [WebMethod]
    public int sub(int x, int y)
    {
        return (x - y);
    }
    [WebMethod]
    public int mul(int x, int y)
    {
        return (x * y);
    }
    [WebMethod]
    public int div(int x, int y)
    {
        return (x / y);
    }
}
