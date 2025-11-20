using AirportApp.Entities;

namespace AirportApp.Services.Contracts
{
    public interface IFlightStorage
    {
        Task Add(FlightModel flight);
        Task Remove(FlightModel flight);
        Task Update(FlightModel flight);
        Task<ICollection<FlightModel>> GetAll();
    }
}