namespace DO;

[Serializable]
public class DalExist:Exception
 {
    //private String message;
    public DalExist(String message)
    {
        throw new DalExist(message);
    }
}

[Serializable]
public class DalNotExist : Exception
{
    //private String message;
    public DalNotExist(String message)
    {
        throw new DalNotExist(message);
    }
}