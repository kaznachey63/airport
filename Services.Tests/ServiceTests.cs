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
        /// Add работает
        /// </summary>
        [Fact]
        public async Task AddShouldWork()
        {
            // Arrange
            var flight = new FlightModel();

            // Act
            await service.Add(flight, ct);

            // Assert
            storageMock.Verify(s => s.Add(flight, ct), Times.Once);
            storageMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// Remove работает
        /// </summary>
        [Fact]
        public async Task RemoveShouldWork()
        {
            // Arrange
            var flight = new FlightModel();

            // Act
            await service.Remove(flight, ct);

            // Assert
            storageMock.Verify(s => s.Remove(flight, ct), Times.Once);
            storageMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// Update работает
        /// </summary>
        [Fact]
        public async Task UpdateShouldWork()
        {
            // Arrange
            var flight = new FlightModel();

            // Act
            await service.Update(flight, ct);

            // Assert
            storageMock.Verify(s => s.Update(flight, ct), Times.Once);
            storageMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// GetAll возвращает значение
        /// </summary>
        [Fact]
        public async Task GetAllShouldReturnValue()
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
            storageMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// GetStatistics возвращает значение
        /// </summary>
        [Fact]
        public async Task GetStatisticsShouldReturnValue()
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
            storageMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// GetAll возвращает пустую коллекцию
        /// </summary>
        [Fact]
        public async Task GetAllShouldReturnEmptyCollection()
        {
            // Arrange
            storageMock
                .Setup(s => s.GetAll(ct))
                .ReturnsAsync(new List<FlightModel>());

            // Act
            var result = await service.GetAll(ct);

            // Assert
            result.Should().BeEmpty();
            storageMock.VerifyNoOtherCalls();
        }
    }
}