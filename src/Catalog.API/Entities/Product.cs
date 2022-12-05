using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Catalog.API.Entities
{
    public class Product
    {
        private string _id = String.Empty;
        private string _name = String.Empty;
        private string _category = String.Empty ;
        private string _summary = String.Empty ;
        private string _description = String.Empty ;
        private string _imageFile = String.Empty ;
        private decimal _price = Decimal.Zero;

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id
        {
            get => _id;
            set => _id = value;
        }

        [BsonElement("Name")]
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Category
        {
            get => _category;
            set => _category = value;
        }

        public string Summary
        {
            get => _summary;
            set => _summary = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public string ImageFile
        {
            get => _imageFile;
            set => _imageFile = value;
        }

        public decimal Price
        {
            get => _price;
            set => _price = value;
        }
    }
}
