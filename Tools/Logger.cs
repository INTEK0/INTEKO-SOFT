using System;
using System.Threading.Tasks;

namespace İNTEKO.Tools
{
    public static class Logger
    {
        public static void Log(string _message)
        {
            Task.Run(async () =>
            {
                using (var db = new IntekodbEntities())
                {
                    Logs log = new Logs();
                    log.UserID = Properties.Settings.Default.UserID;
                    log.Operation = _message;
                    log.Date = DateTime.Now;
                    db.Logs.Add(log);

                    await db.SaveChangesAsync();
                }
            });
        }
    }
}
