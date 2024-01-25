using Microsoft.AspNetCore.Mvc;

namespace Achivment_API.Controllers
{
    public class User
    {
        public int ID { get; set; }
        public string Nickname { get; set; }
        public char Email { get; set; }
        public string Country { get; set; }
        public string  Gender { get; set; }
        public string Training_goal { get; set; }
        public string Kind_of_sport { get; set; }
    }
    public class Achivment
    {
        public int ID { get; set; }
        public DateOnly Date { get; set; }
        public string type_of_achivment { get; set; }
        public string description { get; set; }
        public string photo { get; set; }
        public string video { get; set; }
        public int user_ID { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        public List<User> users = new List<User>();
        /// <summary>
        /// ��������� ������ �������������
        /// </summary>
        /// <returns></returns>

        //POST api/<UsersController>
        [HttpGet]
        public List<User> GetAll()
        {
            return users;
        }
        /// <summary>
        /// �������� ������ ������������
        /// </summary>
        /// <remarks>
        /// ������ �������:
        ///
        ///     POST /Todo
        ///     {
        ///        "ID" : "1",
        ///        "nickname" : "Swag",
        ///        "email" : "qwerty5@asd.com",
        ///        "country" : "German",
        ///        "gender" : "male"
        ///        "training_goal" : "wanna be the best baseball player"
        ///        "kind_of_sport" : "baseball"
        ///     }
        ///
        /// </remarks>
        /// <param name="model">������������</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add(User data)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].ID == data.ID)
                {
                    return BadRequest("������������ � ����� ID ��� ����");
                }
            }
            users.Add(data);
            return Ok();
        }
        /// <summary>
        /// ���������� ������ ������������
        /// </summary>
        /// <remarks>
        /// ������ �������:
        ///
        ///     POST /Todo
        ///     {
        ///        "ID" : "1",
        ///        "nickname" : "Swag",
        ///        "email" : "qwerty5@asd.com",
        ///        "country" : "German",
        ///        "gender" : "male"
        ///        "training_goal" : "wanna be the best baseball player"
        ///        "kind_of_sport" : "baseball"
        ///     }
        ///
        /// </remarks>
        /// <param name="model">������������</param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update(User data)
        {
            for(int i = 0;i < users.Count;i++)
            {
                if (users[i].ID == data.ID) 
                {
                    users[i] = data;
                    return Ok();
                }
            }
            return BadRequest("����� ������������ �� ���������");
        }
        /// <summary>
        /// �������� ������ ������������
        /// </summary>
        /// <remarks>
        /// ������ �������:
        ///
        ///     POST /Todo
        ///     {
        ///        "ID" : "1",
        ///     }
        ///
        /// </remarks>
        /// <param name="model">������������</param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(int id)
        {
           for(int i =0;i<users.Count;i++)
            {
                if (users[i].ID == id)
                {
                    users.RemoveAt(i);
                    return Ok();
                }
            }
            return BadRequest("����� ������������ �� ���������");
        }
        /// <summary>
        /// ��������� ������ ������������ �� ��� ID
        /// </summary>
        /// <remarks>
        /// ������ �������:
        ///
        ///     POST /Todo
        ///     {
        ///        "ID" : "1",
        ///     }
        ///
        /// </remarks>
        /// <param name="model">������������</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            for(int i = 0; i < users.Count; i++) 
            {
                if (users[i].ID == id)
                {
                    return Ok(users[i]);
                }
            }
            return BadRequest("����� ������������ �� ���������");
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class AchivmentController : ControllerBase
    {
        private readonly ILogger<AchivmentController> _logger;

        public AchivmentController(ILogger<AchivmentController> logger)
        {
            _logger = logger;
        }
        public List<Achivment> achivments = new List<Achivment>();
        /// <summary>
        /// ��������� ������ � �����������
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Achivment> GetAll()
        {
            return achivments;
        }
        /// <summary>
        /// �������� ����������
        /// </summary>
        /// <remarks>
        /// ������ �������:
        ///
        ///     POST /Todo
        ///     {
        ///        "ID" : "1",
        ///        "date" : "01.01.24",
        ///        "type_of_achivment" : "fast win",
        ///        "desription" : "a few homerans",
        ///        "photo" : "homeran.jpg",
        ///        "video" : "homeran.asf",
        ///        "user_ID" : "1",
        ///     }
        ///
        /// </remarks>
        /// <param name="model">������������</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add(Achivment data)
        {
            for (int i = 0; i < achivments.Count; i++)
            {
                if (achivments[i].ID == data.ID)
                {
                    return BadRequest("������ � ����� ID ��� ����");
                }
            }
            achivments.Add(data);
            return Ok();
        }
        /// <summary>
        /// ���������� ����������
        /// </summary>
        /// <remarks>
        /// ������ �������:
        ///
        ///     POST /Todo
        ///     {
        ///        "ID" : "1",
        ///        "date" : "01.01.24",
        ///        "type_of_achivment" : "fast win",
        ///        "desription" : "a few homerans",
        ///        "photo" : "homeran.jpg",
        ///        "video" : "homeran.asf",
        ///        "user_ID" : "1",
        ///     }
        ///
        /// </remarks>
        /// <param name="model">������������</param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update(Achivment data)
        {
            for (int i = 0; i < achivments.Count; i++)
            {
                if (achivments[i].ID == data.ID)
                {
                    achivments[i] = data;
                    return Ok();
                }
            }
            return BadRequest("����� ������ �� ����������");
        }
        /// <summary>
        /// �������� ����������
        /// </summary>
        /// <remarks>
        /// ������ �������:
        ///
        ///     POST /Todo
        ///     {
        ///        "ID" : "1",
        ///     }
        ///
        /// </remarks>
        /// <param name="model">������������</param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            for (int i = 0; i < achivments.Count; i++)
            {
                if (achivments[i].ID == id)
                {
                    achivments.RemoveAt(i);
                    return Ok();
                }
            }
            return BadRequest("����� ������ �� ����������");
        }
        /// <summary>
        /// ��������� ������ ���������� �� ��� ID
        /// </summary>
        /// <remarks>
        /// ������ �������:
        ///
        ///     POST /Todo
        ///     {
        ///        "ID" : "1",
        ///     }
        ///
        /// </remarks>
        /// <param name="model">������������</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            for (int i = 0; i < achivments.Count; i++)
            {
                if (achivments[i].ID == id)
                {
                    return Ok(achivments[i]);
                }
            }
            return BadRequest("����� ������ �� ����������");
        }
    }
}