using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    interface MVCFeature<clase>
    {
        void create(clase obj);

        void update(clase obj);

        void delete(clase obj);

        clase find(clase obj);

        List<clase> findAll();
    }
}
