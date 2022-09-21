using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoviesAPI.Data;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
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
            _timer?.Dispose();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(Dowork, null, TimeSpan.Zero, TimeSpan.FromDays(1));
            return Task.CompletedTask;
            //throw new NotImplementedException();
        }

        private async void Dowork(object state)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                var today = DateTime.Today;
                var movies = await context.Movies.Where(x => x.ReleaseDate == today).ToListAsync();
                if (movies.Any())
                {
                    foreach (var movie in movies)
                    {
                        movie.InTheaters = true;
                    }
                    await context.SaveChangesAsync();
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }
    }
}