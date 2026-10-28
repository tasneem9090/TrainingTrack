namespace TrainingTrack.Services
{
    public class FileService : IFileService
    {

        public string SaveFile(IFormFile file)
        {
            // أنواع الملفات المسموح بها
            string[] allowedExtensions =
            {
            ".jpg",
            ".jpeg",
            ".png",
            ".gif",
            ".pdf"
        };

            // امتداد الملف
            string extension = Path.GetExtension(file.FileName).ToLower();

            // التأكد أن نوع الملف مسموح
            if (!allowedExtensions.Contains(extension))
            {
                throw new Exception("نوع الملف غير مسموح");
            }

            // اسم جديد للملف
            string fileName = Guid.NewGuid().ToString() + extension;

            // مكان حفظ الملفات
            string folder = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "Uploads"
            );

            // إنشاء المجلد إذا لم يكن موجودًا
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            // المسار الكامل للملف
            string filePath = Path.Combine(folder, fileName);

            // حفظ الملف
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            // إرجاع اسم الملف
            return fileName;
        }
    }


}

