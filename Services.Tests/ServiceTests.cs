using AirportApp.Entities;
using AirportApp.Repositories.Contracts;
using AirportApp.Services.Contracts;
using FluentAssertions;
using Moq;
using Xunit;

namespace AirportApp.Services.Tests
{
    /// <summary>
    /// Набор модульных тестов для проверки работы <see cref="FlightService"/>.
    /// </summary>
    public class FlightServiceTests
    {
        private readonly Mock<IFlightStorage> storageMock;
        private readonly IFlightService service;
        private readonly CancellationToken ct = CancellationToken.None;

        public FlightServiceTests()
        {
            storageMock = new Mock<IFlightStorage>();
            service = new FlightService(storageMock.Object);
        }

        /// <summary>
        /// Проверяет, что при добавлении рейса сервис вызывает метод Add хранилища.
        /// </summary>
        [Fact]
        public async Task AddShouldCallStorageAdd()
        {
            // Arrange
            var flight = new FlightModel();

            // Act
            await service.Add(flight, ct);

            // Assert
            storageMock.Verify(s => s.Add(flight, ct), Times.Once);
        }

        /// <summary>
        /// Проверяет, что при удалении рейса сервис вызывает метод Remove хранилища.
        /// </summary>
        [Fact]
        public async Task RemoveShouldCallStorageRemove()
        {
            // Arrange
            var flight = new FlightModel();

            // Act
            await service.Remove(flight, ct);

            // Assert
            storageMock.Verify(s => s.Remove(flight, ct), Times.Once);
        }

        /// <summary>
        /// Проверяет, что при обновлении рейса сервис вызывает метод Update хранилища.
        /// </summary>
        [Fact]
        public async Task UpdateShouldCallStorageUpdate()
        {
            // Arrange
            var flight = new FlightModel();

            // Act
            await service.Update(flight, ct);

            // Assert
            storageMock.Verify(s => s.Update(flight, ct), Times.Once);
        }

        /// <summary>
        /// Проверяет, что сервис возвращает все рейсы из хранилища.
        /// </summary>
        [Fact]
        public async Task GetAllShouldReturnDataFromStorage()
        {
            // Arrange
            var flights = new List<FlightModel>
            {
                new FlightModel { FlightNumber = 123 },
                new FlightModel { FlightNumber = 228 }
            };

            storageMock
                .Setup(s => s.GetAll(ct))
                .ReturnsAsync(flights);

            // Act
            var result = await service.GetAll(ct);

            // Assert
            result.Should().BeEquivalentTo(flights);
        }

        /// <summary>
        /// Проверяет, что сервис возвращает корректную статистику рейсов.
        /// </summary>
        [Fact]
        public async Task GetStatisticsShouldReturnDataFromStorage()
        {
            // Arrange
            var expected = new FlightStatistics(10, 1500, 120, 3000000m);
            storageMock
                .Setup(s => s.GetStatistics(ct))
                .ReturnsAsync(expected);

            // Act
            var result = await service.GetStatistics(ct);

            // Assert
            result.Should().BeSameAs(expected);
        }

        /// <summary>
        /// Проверяет, что сервис корректно обрабатывает пустую коллекцию рейсов.
        /// </summary>
        [Fact]
        public async Task GetAllShouldReturnEmptyCollectionWhenStorageIsEmpty()
        {
            // Arrange
            storageMock
                .Setup(s => s.GetAll(ct))
                .ReturnsAsync(new List<FlightModel>());

            // Act
            var result = await service.GetAll(ct);

            // Assert
            result.Should().BeEmpty();
        }
    }
}