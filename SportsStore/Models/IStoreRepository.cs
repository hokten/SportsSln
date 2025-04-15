namespace SportsStore.Models;

public interface IStoreRepository {
		IQueryable<Product> Urunler { get; }
}
