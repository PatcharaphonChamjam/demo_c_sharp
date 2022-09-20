using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MoviesAPI.Services
{
    public class MoviesInTheaterService : IHostedService, IDisposable
    {
        private readonly IServiceProvider serviceProvider;
        private Timer _timer;

        public MoviesInTheaterService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            /*timer = new Timer(Dowork, null, TimeSpan.Zero, TimeSpan.FromDays(1));
            return Task.CompletedTask;*/
            throw new NotImplementedException();
        }

        private void Dowork(object state)
        {
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}