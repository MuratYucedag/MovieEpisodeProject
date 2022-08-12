using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using EntityLayer.Entities;
using FacadeLayer;
using FacadeLayer.Dal;

namespace BusinessLogicLayer.BL
{
    public class BLActor
    {
        public static List<EntityActor> BLActorList()
        {
            return DALActor.ActorList();
        }

        public static void BLAddActor(EntityActor p)
        {
            if(p.actorName!="" && p.actorSurname !="" && p.actorAge.Length == 2)
            {
                DALActor.AddActor(p);
            }
            else
            {
                //hata mesajları
            }
        }

        public static void BLDeleteActor(int id)
        {
            if (id != 0)
            {
                DALActor.DeleteActor(id);
            }
        }

        public static void BLUpdateActor(EntityActor p)
        {
            if(p.actorName!="" && p.actorSurname.Length >= 4)
            {
                DALActor.UpdateActor(p);
            }
        }
    }
}
