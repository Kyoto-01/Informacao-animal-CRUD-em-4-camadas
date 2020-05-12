using System;
using System.Collections.Generic;
using AnimalInfo.DAL;
using AnimalInfo.DTO;

namespace AnimalInfo.BLL
{
    public class AnimalInfo_BLL
    {
        public string enderecoFotos
        {
            get { return System.IO.Directory.GetCurrentDirectory() + "\\fotos\\"; }
        }

        public List<Animal> buscarAnimais()
        {
            try
            {
                return new AnimalInfo_DAL().BuscarAnimais();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int EditarAnimal(Animal animalEditado)
        {
            try
            {
                return new AnimalInfo_DAL().UpdateAnimal(animalEditado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddAnimal(Animal novoAnimal)
        {
            try
            {
                return new AnimalInfo_DAL().AddAnimal(novoAnimal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int RemoveAnimal(Animal animalToRemove)
        {
            try
            {
                return new AnimalInfo_DAL().RemoveAnimal(animalToRemove);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
