using SampleDataContext.DBClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataContext.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        void Save();
        IGenericRepository<Question> ModelRepository { get; }
        IGenericRepository<QuestionContent> QuestionContentRepository { get; }
        IGenericRepository<QuestionCategory> QuestionCategoryRepository { get; }
            
    }
}
