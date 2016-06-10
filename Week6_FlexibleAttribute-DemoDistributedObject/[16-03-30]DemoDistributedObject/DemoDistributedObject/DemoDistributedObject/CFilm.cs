using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDistributedObject
{
    public class CFilm : ClientObject
    {
        public CFilm(string tenFilm, float diem)
        {
            AttachHandle(
                ClientObjectManager.CreateRemoteObject(this.GetClassName()));
            this.TenFilm = tenFilm;
            this.DanhGia = diem;
        }

        public override string GetClassName()
        {
            return "Film";
        }

        public string TenFilm
        {
            get
            {
                return (string)ClientObjectManager.GetAttributeValue(Handle, "Tên");
            }
            set
            {
                ClientObjectManager.SetAttributeValue(Handle, "Tên", value);
            }
        }

        public float DanhGia
        {
            get
            {
                return (float)ClientObjectManager.GetAttributeValue(Handle, "Đánh giá");
            }
            set
            {
                ClientObjectManager.SetAttributeValue(Handle, "Đánh giá", value);
            }
        }





    }
}