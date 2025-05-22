namespace DO;

//:מאפייני המוצר
//מזהה יחודי(מספור אוטומטי), שם המוצר, קטגוריה, מחיר, מספר יחידות במלאי

public record Product
    (int id,
    string? name,
    categories? category,
    double price,
    int count)
{

    public Product() : this(0, "", categories.אלקטרוניקה, 0.0, 0)
    {
        //id = 0;
    }
}
