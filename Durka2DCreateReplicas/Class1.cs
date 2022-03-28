using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durka2DCreateReplicas
{
    [Serializable]
    public class Replicas //хранит коллекцию реплик
    {
        public List<Replica> ReplicasList { get; set; } = new List<Replica>();
    }

    [Serializable]
    public class Replica // в нем будет содержаться поля
    {
        public string replica { get; set; }
        public string CharacterName { get; set; }
        public Replica()
        {

        }
        public Replica(string _Replica, string CharacterName)
        {
            this.replica = _Replica;
            this.CharacterName = CharacterName;
        }
    }
}
