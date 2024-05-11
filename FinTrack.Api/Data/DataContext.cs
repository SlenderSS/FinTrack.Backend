using Microsoft.EntityFrameworkCore;

namespace FinTrack.Api.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {


    }
}
