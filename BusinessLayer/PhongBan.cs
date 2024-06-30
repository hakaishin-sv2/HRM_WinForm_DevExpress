using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
namespace BusinessLayer
{
    public class PhongBan
    {
        HRMEntities hrm = new HRMEntities();

        public List<tb_PHONGBAN> getListPhongBan()
        {
            return hrm.tb_PHONGBAN.ToList();
        }

        public tb_PHONGBAN Them(tb_PHONGBAN data)
        {
            try
            {
                hrm.tb_PHONGBAN.Add(data);
                hrm.SaveChanges();
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);

            }
        }
        public tb_PHONGBAN Update(tb_PHONGBAN data)
        {
            try
            {
                var row_update = hrm.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == data.IDPB);

                if (row_update != null)
                {
                    row_update.TENPB = data.TENPB;
                    hrm.SaveChanges();
                    return data;
                }
                else
                {
                    throw new Exception("Bản ghi không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);

            }
        }
        public tb_PHONGBAN getItem(int id)
        {
            return hrm.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == id);
        }
        public tb_PHONGBAN Xoa(int id)
        {
            try
            {
                var row_to_delete = hrm.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == id);
                if (row_to_delete != null)
                {
                    hrm.tb_PHONGBAN.Remove(row_to_delete);
                    hrm.SaveChanges();
                    return row_to_delete;
                }
                else
                {
                    throw new Exception("Bản ghi không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        
    }
}
