namespace clean_architecture_template;

public class GeneralApiResponse<T>
{
    public bool Success { get; set; }
    public T? Data { get; set; }
    public string Message { get; set; }
}

public class GeneralApiResponse
{
    public bool Success { get; set; }
    public string? Message { get; set; }
}
