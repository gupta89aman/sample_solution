using SampleDataContext.DBClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataContext.Repository
{
    public class UnitOfWork:IUnitOfWork,IDisposable
    {
        private readonly QuestionaireDBContext _dbCOntext;
        private IGenericRepository<Question> _modelRepository;
        private IGenericRepository<QuestionContent> _questionContentRepository;
        private IGenericRepository<QuestionCategory> _questionCategoryRepository;
        public UnitOfWork(QuestionaireDBContext context)
        {
            _dbCOntext = context;
        }
        public UnitOfWork()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<QuestionaireDBContext, System.Data.Entity.Migrations.DbMigrationsConfiguration<QuestionaireDBContext>>(true));
            //var context = new QuestionaireDBContext(@"Data Source=SCB-D-SSDEV11\\SQLEXPRESS;Initial Catalog=SampleQuestionDB;IntegratedSecurity=True;");
            //context.Database.Initialize(true);
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<QuestionaireDBContext>());
            _dbCOntext = new QuestionaireDBContext();
            //var connection = ((IObjectContextAdapter)_dbCOntext).ObjectContext.Connection;
            //connection.Open();
        }
        public IGenericRepository<Question> ModelRepository
        {
            get { return _modelRepository ?? (_modelRepository = new GenericRepository<Question>(_dbCOntext)); }
        }
        public IGenericRepository<QuestionContent> QuestionContentRepository
        {
            get { return _questionContentRepository ?? (_questionContentRepository = new GenericRepository<QuestionContent>(_dbCOntext)); }
        }
        public IGenericRepository<QuestionCategory> QuestionCategoryRepository
        {
            get { return _questionCategoryRepository ?? (_questionCategoryRepository = new GenericRepository<QuestionCategory>(_dbCOntext)); }
        }

        public void Save()
        {
            _dbCOntext.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbCOntext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
    }
}
