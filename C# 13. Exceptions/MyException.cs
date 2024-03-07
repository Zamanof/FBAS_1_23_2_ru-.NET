/*
■ исключение должно быть наследником ApplicationException;
■ у исключения должен быть указан атрибут [Serializable];
■ у исключения должен быть конструктор по умолчанию;
■ у исключения должен быть перегруженный конструктор для установки свойства Message;
■ должен быть перегруженный конструктор для обработки внутренних исключений;
■ должен быть перегруженный конструктор, выполняющий сериализацию типа
*/


[Serializable]
public class MyException : Exception
{
	public MyException() { }
	public MyException(string message) : base(message) { }
	public MyException(string message, Exception inner) : base(message, inner) { }
	protected MyException(
	  System.Runtime.Serialization.SerializationInfo info,
	  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}

