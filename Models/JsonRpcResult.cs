public class JsonRpcResult<T>
{
    public T Result { get; set; }
    public JsonRpcError Error { get; set; }

    public void EnsureSuccess() {
        if (Error != null)
            throw new Exception(Error.Message);
    }
}

public class JsonRpcError
{
    public int Code { get; set; }
    public string Message { get; set; }
}
