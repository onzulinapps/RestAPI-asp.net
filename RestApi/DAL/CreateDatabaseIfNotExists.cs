using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Configuration;
namespace RestApi.DAL
{
    public class CreateDatabaseIfNotExists<TContext> : IDatabaseInitializer<TContext>
    where TContext : DbContext
    {
        public IEnumerable<string> Sentences { get; set; }



        public void InitializeDatabase(TContext context)
        {

            var created = false;

            if (!context.Database.Exists())
            {

                context.Database.Create();

                created = true;

            }

            else
            {

                var dropIsRequired = false;

                if (ConfigurationManager.AppSettings["DropIsRequired"] != null)
                {

                    var result = false;

                    if (bool.TryParse(ConfigurationManager.AppSettings["DropIsRequired"], out result))
                    {

                        dropIsRequired = result;

                    }

                }

                if (dropIsRequired || !context.Database.CompatibleWithModel(false))
                {

                    context.Database.Delete();

                    context.Database.Create();

                    created = true;

                }

            }

            if (created && Sentences != null)
            {

                foreach (var sentence in Sentences)
                {

                    context.Database.ExecuteSqlCommand(sentence);

                }

            }

        }
    }
}