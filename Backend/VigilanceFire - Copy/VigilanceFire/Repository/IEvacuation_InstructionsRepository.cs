using Microsoft.EntityFrameworkCore;
using VigilanceFire.Data;
using VigilanceFire.Models;

namespace VigilanceFire.Repository
{
    public interface IEvacuation_InstructionsRepository
    {
        List<Evacuation_Instructions> GetAllInstructions();
        Evacuation_Instructions GetInstructionById(int id);
        public void AddInstruction(Evacuation_Instructions instruction);
        public void UpdateInstruction(Evacuation_Instructions instruction);
        public void DeleteInstruction(int id);
    }

    public class Evacuation_InstructionsRepository : IEvacuation_InstructionsRepository
    {
        VigilanceFireContext db = new VigilanceFireContext();
        public void AddInstruction(Evacuation_Instructions instruction)
        {
            db.Instructions.Add(instruction);
            db.SaveChanges();
        }

        public void DeleteInstruction(int id)
        {
            var instruction = GetInstructionById(id);
            if (instruction != null)
            {
                db.Instructions.Remove(instruction);
                db.SaveChanges();
            }
        }

        public List<Evacuation_Instructions> GetAllInstructions()
        {
            return db.Instructions.ToList();
        }

        public Evacuation_Instructions GetInstructionById(int id)
        {
            return db.Instructions.SingleOrDefault(i => i.evacuation_Id == id);
        }

        public void UpdateInstruction(Evacuation_Instructions instruction)
        {
            db.Instructions.Update(instruction);
            db.SaveChanges();
        }
    }
}
