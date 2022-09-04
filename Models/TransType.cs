public class TransType
{
    public string Tt_Id { get; set; }
    public string Tt_Title { get; set; }
    public TransTypeRoute[] Routes { get; set; }
}

public class TransTypeRoute
{
    public string Mr_Id { get; set; }
    public string Mr_Num { get; set; }
    public string Mr_Title { get; set; }
}