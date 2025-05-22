namespace DO;

//:מאפייני לקוח
//תעודת זהות, שם לקוח, כתובת, טלפון
public record Customer
    (int Id,
    string? Name,
    string? Address,
    string? Telephone)
{

    public Customer() : this(0, null, "", "")
    {

    }
}
