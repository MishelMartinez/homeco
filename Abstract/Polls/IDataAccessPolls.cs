using InmobiliariasHomeCo.Entities.Pojos.Poll;
using InmobiliariasHomeCo.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Abstract.Polls
{
    public interface IDataAccessPolls
    {

        DatesSecurity RegisterSurvey  (DatesSecurity dates);

        PollMessage RegisterPoll(PollMessage dates);

    }
}
