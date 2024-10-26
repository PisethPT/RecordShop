namespace RecordShop.Services
{
	public interface ICRUDOperation<T>
	{
		List<T> GetAll();
		string Insert(T type);
		string Update(T type, int Id);
		string Delete(int Id);

	}
}
