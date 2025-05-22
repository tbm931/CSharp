namespace DO;

//:מאפייני מבצע
//מזהה יחודי(מיספור אוטומטי), מזהה מוצר, כמות נדרשת, מחיר
// האם מיועד לכל הלקוחות או רק ללקוחות המועדון,
//תאריך התחלה, תאריך סיום,

public record Sale(
    int Id,
    int? ProdId,
    int MinCount,
    double AllPrice,
    bool IsToAll,
    DateTime? Begin,
    DateTime? Finish)
{
    public Sale() : this(0, 0, 0, 0.0, true, new DateTime(01 / 01 / 2000), new DateTime(01 / 01 / 2025))
    {

    }
}
