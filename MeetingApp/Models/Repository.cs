namespace MeetingApp.Models
{
    public static class Repository
    {

        public static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Özge", Phone = "0 507 903 05 71", Email = "ozge.bahceci@hotmail.com", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Huriye", Phone = "0 555 903 65 45", Email = "huriye.bahceci@hotmail.com", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Kadir", Phone = "0 545 543 34 78", Email = "kadir.bahceci@hotmail.com", WillAttend = true });
            _users.Add(new UserInfo() { Id = 4, Name = "Burhan", Phone = "0 537 768 81 90", Email = "burhan@hotmail.com", WillAttend = false });
            _users.Add(new UserInfo() { Id = 5, Name = "Sacit", Phone = "0 536 112 01 06", Email = "sacit@hotmail.com", WillAttend = true });
            _users.Add(new UserInfo() { Id = 6, Name = "Hacer", Phone = "0 542 087 22 17", Email = "hacer@hotmail.com", WillAttend = false });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreatedUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            // listeye yeni user ekleme
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            //eğer aranılan değer bulunmazsa geriye null değer döndürebilir diye 
            //nullable yapıldı

            //User detayı görüntülenmek istediğinde o id'de bağlı
            // User bilgisi getirilir
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
