using Computer_Club.Model;
using Computer_Club.Model.DataBaseModels;
using Computer_Club.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Computer_Club.Services.Implementations
{
    public class ComputerService:IComputer
    {
        private readonly ApplicationDataBaseContext applicationDataBaseContext;

        public ComputerService(ApplicationDataBaseContext applicationContext)
        {
            applicationDataBaseContext = applicationContext;
        }

        public void Create(Computer computer)
        {
            applicationDataBaseContext.Computers.Add(computer);
            applicationDataBaseContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var computer = applicationDataBaseContext.Computers.FirstOrDefault(x => x.Id == id);
            if (computer != null)
            {
                applicationDataBaseContext.Computers.Remove(computer);
                applicationDataBaseContext.SaveChanges();
            }
            throw new Exception("Computer not found!");
        }

        public Computer GetComputer(int id)
        {
            return applicationDataBaseContext.Computers.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Computer> GetComputers() => applicationDataBaseContext.Computers.AsNoTracking().ToList();

        public void Update(int id, Computer computer)
        {
            var updateComputer = applicationDataBaseContext.Computers.FirstOrDefault(x => x.Id == id);
            if (updateComputer == null)
            {
                throw new Exception("Game not found");
            }
            updateComputer = computer;
            applicationDataBaseContext.Computers.Update(updateComputer);
            applicationDataBaseContext.SaveChanges();
        }
    }
}

