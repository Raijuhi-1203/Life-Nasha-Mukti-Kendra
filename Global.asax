<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RegisterRoutes(RouteTable.Routes);
    }

    static void RegisterRoutes(RouteCollection routes)
    {
       
        routes.MapPageRoute("About", "about-us", "~/about.aspx");
        routes.MapPageRoute("Contact", "contact-us", "~/contact.aspx");
        routes.MapPageRoute("Service", "service", "~/service.aspx");
        routes.MapPageRoute("Index", "best-nasha-mukti-kendra-in-gorakhpur", "~/index.aspx");
        routes.MapPageRoute("privacy-policy", "privacy-policy", "~/privacy-policy.aspx");
        
    }

    void Application_End(object sender, EventArgs e)
    {
        
    }

    void Application_Error(object sender, EventArgs e)
    {
       
    }

    void Session_Start(object sender, EventArgs e)
    {
        
    }

    void Session_End(object sender, EventArgs e)
    {
        
    }

</script>
