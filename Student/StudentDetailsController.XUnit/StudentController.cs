using Student.Models.Domain;
using Student.Repositories;

namespace StudentDetailsController.XUnit
{
    public class StudentDetailsController : IStudentDetailRepository
    {
        private readonly List<StudentDetail> _shoppingCart;

        public StudentDetailsController()
        {
            _shoppingCart = new List<StudentDetail>()
            {
                new StudentDetail() {
                    Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                    Name = "Orange Juice",
                    City ="Pune" },
                new StudentDetail() {
                    Id = new Guid("815accac-fd5b-478a-a9d6-f171a2f6ae7f"),
                    Name = "Diary Milk",
                    City = "Banglore"},
                new StudentDetail() {
                    Id = new Guid("33704c4a-5b87-464c-bfb6-51971b4d18ad"),
                    Name = "Frozen Pizza",
                    City = "China" }
            };
        }

        //public IEnumerable<StudentDetail> GetAllItems()
        //{
        //    return _shoppingCart;
        //}

        //public StudentDetail Add(StudentDetail newItem)
        //{
        //    newItem.Id = Guid.NewGuid();
        //    _shoppingCart.Add(newItem);
        //    return newItem;
        //}

        //public StudentDetail GetById(Guid id)
        //{
        //    return _shoppingCart.Where(a => a.Id == id)
        //        .FirstOrDefault();
        //}

        //public void Remove(Guid id)
        //{
        //    var existing = _shoppingCart.First(a => a.Id == id);
        //    _shoppingCart.Remove(existing);
        //}
    }
}