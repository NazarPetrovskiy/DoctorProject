using ClientBLL.Interfaces;
using ClientBLL.Models;
using ClientDAL.IRepository;
using ClientDAL.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBLL.Services
{
    public class AnalysisDTOServiceTranslator : IServiceTranslator<AnalysisDTO, Analysis>
    {
        public Analysis Add(AnalysisDTO item)
        {
            Analysis tempAnalysis = new Analysis()
            {
                Id = item.Id,
                Name = item.Name,
                Value = item.Value
            };

            return tempAnalysis;
        }

        public IList<AnalysisDTO> GetAll(IList<Analysis> items)
        {
            IList<AnalysisDTO> analysisDTOs = null;
            if (items.Count > 0)
            {
                analysisDTOs = new List<AnalysisDTO>();
                AnalysisDTO tempAnalysis = new AnalysisDTO();

                foreach (var item in items)
                {
                    tempAnalysis.Id = item.Id;
                    tempAnalysis.Name = item.Name;
                    tempAnalysis.Value = item.Value;

                    analysisDTOs.Add(tempAnalysis);
                }
            }

            return analysisDTOs;
        }

        public AnalysisDTO GetItem(Analysis item)
        {
            AnalysisDTO analysisDTO = new AnalysisDTO()
            {
                Id = item.Id,
                Name = item.Name,
                Value = item.Value
            };

            return analysisDTO;
        }

        public Analysis Update(AnalysisDTO item)
        {
            return new Analysis()
            {
                Id = item.Id,
                Name = item.Name,
                Value = item.Value
            };
        }
    }
}