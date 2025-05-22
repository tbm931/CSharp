namespace BO;
[Serializable]
public class BlIdNoFound : Exception
{
    public BlIdNoFound(string message) : base(message) { }
    public BlIdNoFound(string message, DO.DalNotExist dalIdExists) : base(message, dalIdExists) { }

}
[Serializable]
public class BlNotExists : Exception
{
    public BlNotExists(string message) : base(message) { }
    public BlNotExists(string message, DO.DalNotExist dalIdNoFound) : base(message, dalIdNoFound) { }
}
[Serializable]
public class BlInvalidInput(string message) : Exception(message)
{
}
[Serializable]
public class BlOutOfStock(string message) : Exception(message)
{
}