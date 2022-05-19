using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using WebAPICasino.DTOs;
using WebAPICasino.Entidades;

namespace WebAPICasino.Controllers
{

    [ApiController]
    [Route("rifas")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]

    public class RifasController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        
        public RifasController(ApplicationDbContext context, IMapper mapper)
        {
            this.dbContext = context;
            this.mapper = mapper;
        }

        [HttpGet("/TodasLasRifas")] //Admin vista
        public async Task<ActionResult<List<Rifa>>> GetAll() 
        {
            return await dbContext.Rifas.ToListAsync();
        }



        //GET PARA NÚMEROS DE ESA RIFA DISPONIBLES (Una lista con los números disponibles (null) del 1-54)
        [HttpGet("{nombre}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<LoteriaDTO>>> Get([FromRoute] string nombre) //Hacer otro dto
        {
            List<string> Loteria = new();

            var exist = await dbContext.Rifas.Where(rifaBD => rifaBD.Nombre.Equals(nombre)).FirstOrDefaultAsync();

            if (exist != null)
            {
                bool num1 = await dbContext.Rifas.AnyAsync(n => n.Numero1.Equals(null));
                if (num1)
                {
                    Loteria.Add("1. El Gallo");
                }
                bool num2 = await dbContext.Rifas.AnyAsync(n => n.Numero2.Equals(null));
                if (num2)
                {
                    Loteria.Add("2. El Diablo");
                }
                bool num3 = await dbContext.Rifas.AnyAsync(n => n.Numero3.Equals(null));
                if (num3)
                {
                    Loteria.Add("3. La Dama");
                }
                bool num4 = await dbContext.Rifas.AnyAsync(n => n.Numero4.Equals(null));
                if (num4)
                {
                    Loteria.Add("4. El Catrín");
                }
                bool num5 = await dbContext.Rifas.AnyAsync(n => n.Numero5.Equals(null));
                if (num5)
                {
                    Loteria.Add("5. El Paraguas");
                }
                bool num6 = await dbContext.Rifas.AnyAsync(n => n.Numero6.Equals(null));
                if (num6)
                {
                    Loteria.Add("6. La Sirena");
                }
                bool num7 = await dbContext.Rifas.AnyAsync(n => n.Numero7.Equals(null));
                if (num7)
                {
                    Loteria.Add("7. La Escalera");
                }
                bool num8 = await dbContext.Rifas.AnyAsync(n => n.Numero8.Equals(null));
                if (num8)
                {
                    Loteria.Add("8. La Botella");
                }
                bool num9 = await dbContext.Rifas.AnyAsync(n => n.Numero9.Equals(null));
                if (num9)
                {
                    Loteria.Add("9. El Barril");
                }
                bool num10 = await dbContext.Rifas.AnyAsync(n => n.Numero10.Equals(null));
                if (num10)
                {
                    Loteria.Add("10. El Árbol");
                }
                bool num11 = await dbContext.Rifas.AnyAsync(n => n.Numero11.Equals(null));
                if (num11)
                {
                    Loteria.Add("11. El Melón");
                }
                bool num12 = await dbContext.Rifas.AnyAsync(n => n.Numero12.Equals(null));
                if (num12)
                {
                    Loteria.Add("12. El Valiente");
                }
                bool num13 = await dbContext.Rifas.AnyAsync(n => n.Numero13.Equals(null));
                if (num13)
                {
                    Loteria.Add("13. El Gorrito");
                }
                bool num14 = await dbContext.Rifas.AnyAsync(n => n.Numero14.Equals(null));
                if (num14)
                {
                    Loteria.Add("14. La Muerte");
                }
                bool num15 = await dbContext.Rifas.AnyAsync(n => n.Numero15.Equals(null));
                if (num15)
                {
                    Loteria.Add("15. La Pera");
                }
                bool num16 = await dbContext.Rifas.AnyAsync(n => n.Numero16.Equals(null));
                if (num16)
                {
                    Loteria.Add("16. La Bandera");
                }
                bool num17 = await dbContext.Rifas.AnyAsync(n => n.Numero17.Equals(null));
                if (num17)
                {
                    Loteria.Add("17. El Bandolón");
                }
                bool num18 = await dbContext.Rifas.AnyAsync(n => n.Numero18.Equals(null));
                if (num18)
                {
                    Loteria.Add("18. El Violincello");
                }
                bool num19 = await dbContext.Rifas.AnyAsync(n => n.Numero19.Equals(null));
                if (num19)
                {
                    Loteria.Add("19. La Garza");
                }
                bool num20 = await dbContext.Rifas.AnyAsync(n => n.Numero20.Equals(null));
                if (num20)
                {
                    Loteria.Add("20. El Pájaro");
                }
                bool num21 = await dbContext.Rifas.AnyAsync(n => n.Numero21.Equals(null));
                if (num21)
                {
                    Loteria.Add("21. La Mano");
                }
                bool num22 = await dbContext.Rifas.AnyAsync(n => n.Numero22.Equals(null));
                if (num22)
                {
                    Loteria.Add("22. La Bota");
                }
                bool num23 = await dbContext.Rifas.AnyAsync(n => n.Numero23.Equals(null));
                if (num23)
                {
                    Loteria.Add("23. La Luna");
                }
                bool num24 = await dbContext.Rifas.AnyAsync(n => n.Numero24.Equals(null));
                if (num24)
                {
                    Loteria.Add("24. El cotorro");
                }
                bool num25 = await dbContext.Rifas.AnyAsync(n => n.Numero25.Equals(null));
                if (num25)
                {
                    Loteria.Add("25. El Borracho");
                }
                bool num26 = await dbContext.Rifas.AnyAsync(n => n.Numero26.Equals(null));
                if (num26)
                {
                    Loteria.Add("26. El Negrito");
                }
                bool num27 = await dbContext.Rifas.AnyAsync(n => n.Numero27.Equals(null));
                if (num27)
                {
                    Loteria.Add("27. El Corazón");
                }
                bool num28 = await dbContext.Rifas.AnyAsync(n => n.Numero28.Equals(null));
                if (num28)
                {
                    Loteria.Add("28. La Sandía");
                }
                bool num29 = await dbContext.Rifas.AnyAsync(n => n.Numero29.Equals(null));
                if (num29)
                {
                    Loteria.Add("29. El Tambor");
                }
                bool num30 = await dbContext.Rifas.AnyAsync(n => n.Numero30.Equals(null));
                if (num30)
                {
                    Loteria.Add("30. El Camarón");
                }
                bool num31 = await dbContext.Rifas.AnyAsync(n => n.Numero31.Equals(null));
                if (num31)
                {
                    Loteria.Add("31. Las Jaras");
                }
                bool num32 = await dbContext.Rifas.AnyAsync(n => n.Numero32.Equals(null));
                if (num32)
                {
                    Loteria.Add("32. El Músico");
                }
                bool num33 = await dbContext.Rifas.AnyAsync(n => n.Numero33.Equals(null));
                if (num33)
                {
                    Loteria.Add("33. La Araña");
                }
                bool num34 = await dbContext.Rifas.AnyAsync(n => n.Numero34.Equals(null));
                if (num34)
                {
                    Loteria.Add("34. El Soldado");
                }
                bool num35 = await dbContext.Rifas.AnyAsync(n => n.Numero35.Equals(null));
                if (num35)
                {
                    Loteria.Add("35. La Estrella");
                }
                bool num36 = await dbContext.Rifas.AnyAsync(n => n.Numero36.Equals(null));
                if (num36)
                {
                    Loteria.Add("36. El Cazo");
                }
                bool num37 = await dbContext.Rifas.AnyAsync(n => n.Numero37.Equals(null));
                if (num37)
                {
                    Loteria.Add("37. El Mundo");
                }
                bool num38 = await dbContext.Rifas.AnyAsync(n => n.Numero38.Equals(null));
                if (num38)
                {
                    Loteria.Add("38. El Apache");
                }
                bool num39 = await dbContext.Rifas.AnyAsync(n => n.Numero39.Equals(null));
                if (num39)
                {
                    Loteria.Add("39. El Nopal");
                }
                bool num40 = await dbContext.Rifas.AnyAsync(n => n.Numero40.Equals(null));
                if (num40)
                {
                    Loteria.Add("40. El Alacrán");
                }
                bool num41 = await dbContext.Rifas.AnyAsync(n => n.Numero41.Equals(null));
                if (num41)
                {
                    Loteria.Add("41. La Rosa");
                }
                bool num42 = await dbContext.Rifas.AnyAsync(n => n.Numero42.Equals(null));
                if (num42)
                {
                    Loteria.Add("42. La Calavera");
                }
                bool num43 = await dbContext.Rifas.AnyAsync(n => n.Numero43.Equals(null));
                if (num43)
                {
                    Loteria.Add("43. La Campana");
                }
                bool num44 = await dbContext.Rifas.AnyAsync(n => n.Numero44.Equals(null));
                if (num44)
                {
                    Loteria.Add("44. El Cantarito");
                }
                bool num45 = await dbContext.Rifas.AnyAsync(n => n.Numero45.Equals(null));
                if (num45)
                {
                    Loteria.Add("45. El Venado");
                }
                bool num46 = await dbContext.Rifas.AnyAsync(n => n.Numero46.Equals(null));
                if (num46)
                {
                    Loteria.Add("46. El Sol");
                }
                bool num47 = await dbContext.Rifas.AnyAsync(n => n.Numero47.Equals(null));
                if (num47)
                {
                    Loteria.Add("47. La Corona");
                }
                bool num48 = await dbContext.Rifas.AnyAsync(n => n.Numero48.Equals(null));
                if (num48)
                {
                    Loteria.Add("48. La Chalupa");
                }
                bool num49 = await dbContext.Rifas.AnyAsync(n => n.Numero49.Equals(null));
                if (num49)
                {
                    Loteria.Add("49. El Pino");
                }
                bool num50 = await dbContext.Rifas.AnyAsync(n => n.Numero50.Equals(null));
                if (num50)
                {
                    Loteria.Add("50. El Pescado");
                }
                bool num51 = await dbContext.Rifas.AnyAsync(n => n.Numero51.Equals(null));
                if (num51)
                {
                    Loteria.Add("51. La Palma");
                }
                bool num52 = await dbContext.Rifas.AnyAsync(n => n.Numero52.Equals(null));
                if (num52)
                {
                    Loteria.Add("52. La Maceta");
                }
                bool num53 = await dbContext.Rifas.AnyAsync(n => n.Numero53.Equals(null));
                if (num53)
                {
                    Loteria.Add("53. El Arpa");
                }
                bool num54 = await dbContext.Rifas.AnyAsync(n => n.Numero54.Equals(null));
                if (num54)
                {
                    Loteria.Add("54. la Rana");
                }
            }
            else
            {
                return NotFound("No se encuentra una rifa con ese nombre");
            }

            var id = await dbContext.Rifas.Where(d => d.Nombre==nombre).Select(d => d.Id).FirstOrDefaultAsync();
            List<LoteriaDTO> rifas = new()
            {
                new LoteriaDTO() { Id = id,CartasDisponibles = Loteria}
            };

            return mapper.Map<List<LoteriaDTO>>(rifas);
        }

        //GET PARA NÚMEROS DE ESA RIFA DISPONIBLES (Una lista con los números disponibles (null) del 1-54)
        [HttpGet("{id:int}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<LoteriaDTO>>> Get([FromRoute] int id) //Hacer otro dto
        {
            List<string> Loteria = new();

            var exist = await dbContext.Rifas.AnyAsync(x => x.Id == id);


            if (exist)
            {
                bool num1 = await dbContext.Rifas.AnyAsync(n => n.Numero1.Equals(null));
                if (num1)
                {
                    Loteria.Add("1. El Gallo");
                }
                bool num2 = await dbContext.Rifas.AnyAsync(n => n.Numero2.Equals(null));
                if (num2)
                {
                    Loteria.Add("2. El Diablo");
                }
                bool num3 = await dbContext.Rifas.AnyAsync(n => n.Numero3.Equals(null));
                if (num3)
                {
                    Loteria.Add("3. La Dama");
                }
                bool num4 = await dbContext.Rifas.AnyAsync(n => n.Numero4.Equals(null));
                if (num4)
                {
                    Loteria.Add("4. El Catrín");
                }
                bool num5 = await dbContext.Rifas.AnyAsync(n => n.Numero5.Equals(null));
                if (num5)
                {
                    Loteria.Add("5. El Paraguas");
                }
                bool num6 = await dbContext.Rifas.AnyAsync(n => n.Numero6.Equals(null));
                if (num6)
                {
                    Loteria.Add("6. La Sirena");
                }
                bool num7 = await dbContext.Rifas.AnyAsync(n => n.Numero7.Equals(null));
                if (num7)
                {
                    Loteria.Add("7. La Escalera");
                }
                bool num8 = await dbContext.Rifas.AnyAsync(n => n.Numero8.Equals(null));
                if (num8)
                {
                    Loteria.Add("8. La Botella");
                }
                bool num9 = await dbContext.Rifas.AnyAsync(n => n.Numero9.Equals(null));
                if (num9)
                {
                    Loteria.Add("9. El Barril");
                }
                bool num10 = await dbContext.Rifas.AnyAsync(n => n.Numero10.Equals(null));
                if (num10)
                {
                    Loteria.Add("10. El Árbol");
                }
                bool num11 = await dbContext.Rifas.AnyAsync(n => n.Numero11.Equals(null));
                if (num11)
                {
                    Loteria.Add("11. El Melón");
                }
                bool num12 = await dbContext.Rifas.AnyAsync(n => n.Numero12.Equals(null));
                if (num12)
                {
                    Loteria.Add("12. El Valiente");
                }
                bool num13 = await dbContext.Rifas.AnyAsync(n => n.Numero13.Equals(null));
                if (num13)
                {
                    Loteria.Add("13. El Gorrito");
                }
                bool num14 = await dbContext.Rifas.AnyAsync(n => n.Numero14.Equals(null));
                if (num14)
                {
                    Loteria.Add("14. La Muerte");
                }
                bool num15 = await dbContext.Rifas.AnyAsync(n => n.Numero15.Equals(null));
                if (num15)
                {
                    Loteria.Add("15. La Pera");
                }
                bool num16 = await dbContext.Rifas.AnyAsync(n => n.Numero16.Equals(null));
                if (num16)
                {
                    Loteria.Add("16. La Bandera");
                }
                bool num17 = await dbContext.Rifas.AnyAsync(n => n.Numero17.Equals(null));
                if (num17)
                {
                    Loteria.Add("17. El Bandolón");
                }
                bool num18 = await dbContext.Rifas.AnyAsync(n => n.Numero18.Equals(null));
                if (num18)
                {
                    Loteria.Add("18. El Violincello");
                }
                bool num19 = await dbContext.Rifas.AnyAsync(n => n.Numero19.Equals(null));
                if (num19)
                {
                    Loteria.Add("19. La Garza");
                }
                bool num20 = await dbContext.Rifas.AnyAsync(n => n.Numero20.Equals(null));
                if (num20)
                {
                    Loteria.Add("20. El Pájaro");
                }
                bool num21 = await dbContext.Rifas.AnyAsync(n => n.Numero21.Equals(null));
                if (num21)
                {
                    Loteria.Add("21. La Mano");
                }
                bool num22 = await dbContext.Rifas.AnyAsync(n => n.Numero22.Equals(null));
                if (num22)
                {
                    Loteria.Add("22. La Bota");
                }
                bool num23 = await dbContext.Rifas.AnyAsync(n => n.Numero23.Equals(null));
                if (num23)
                {
                    Loteria.Add("23. La Luna");
                }
                bool num24 = await dbContext.Rifas.AnyAsync(n => n.Numero24.Equals(null));
                if (num24)
                {
                    Loteria.Add("24. El cotorro");
                }
                bool num25 = await dbContext.Rifas.AnyAsync(n => n.Numero25.Equals(null));
                if (num25)
                {
                    Loteria.Add("25. El Borracho");
                }
                bool num26 = await dbContext.Rifas.AnyAsync(n => n.Numero26.Equals(null));
                if (num26)
                {
                    Loteria.Add("26. El Negrito");
                }
                bool num27 = await dbContext.Rifas.AnyAsync(n => n.Numero27.Equals(null));
                if (num27)
                {
                    Loteria.Add("27. El Corazón");
                }
                bool num28 = await dbContext.Rifas.AnyAsync(n => n.Numero28.Equals(null));
                if (num28)
                {
                    Loteria.Add("28. La Sandía");
                }
                bool num29 = await dbContext.Rifas.AnyAsync(n => n.Numero29.Equals(null));
                if (num29)
                {
                    Loteria.Add("29. El Tambor");
                }
                bool num30 = await dbContext.Rifas.AnyAsync(n => n.Numero30.Equals(null));
                if (num30)
                {
                    Loteria.Add("30. El Camarón");
                }
                bool num31 = await dbContext.Rifas.AnyAsync(n => n.Numero31.Equals(null));
                if (num31)
                {
                    Loteria.Add("31. Las Jaras");
                }
                bool num32 = await dbContext.Rifas.AnyAsync(n => n.Numero32.Equals(null));
                if (num32)
                {
                    Loteria.Add("32. El Músico");
                }
                bool num33 = await dbContext.Rifas.AnyAsync(n => n.Numero33.Equals(null));
                if (num33)
                {
                    Loteria.Add("33. La Araña");
                }
                bool num34 = await dbContext.Rifas.AnyAsync(n => n.Numero34.Equals(null));
                if (num34)
                {
                    Loteria.Add("34. El Soldado");
                }
                bool num35 = await dbContext.Rifas.AnyAsync(n => n.Numero35.Equals(null));
                if (num35)
                {
                    Loteria.Add("35. La Estrella");
                }
                bool num36 = await dbContext.Rifas.AnyAsync(n => n.Numero36.Equals(null));
                if (num36)
                {
                    Loteria.Add("36. El Cazo");
                }
                bool num37 = await dbContext.Rifas.AnyAsync(n => n.Numero37.Equals(null));
                if (num37)
                {
                    Loteria.Add("37. El Mundo");
                }
                bool num38 = await dbContext.Rifas.AnyAsync(n => n.Numero38.Equals(null));
                if (num38)
                {
                    Loteria.Add("38. El Apache");
                }
                bool num39 = await dbContext.Rifas.AnyAsync(n => n.Numero39.Equals(null));
                if (num39)
                {
                    Loteria.Add("39. El Nopal");
                }
                bool num40 = await dbContext.Rifas.AnyAsync(n => n.Numero40.Equals(null));
                if (num40)
                {
                    Loteria.Add("40. El Alacrán");
                }
                bool num41 = await dbContext.Rifas.AnyAsync(n => n.Numero41.Equals(null));
                if (num41)
                {
                    Loteria.Add("41. La Rosa");
                }
                bool num42 = await dbContext.Rifas.AnyAsync(n => n.Numero42.Equals(null));
                if (num42)
                {
                    Loteria.Add("42. La Calavera");
                }
                bool num43 = await dbContext.Rifas.AnyAsync(n => n.Numero43.Equals(null));
                if (num43)
                {
                    Loteria.Add("43. La Campana");
                }
                bool num44 = await dbContext.Rifas.AnyAsync(n => n.Numero44.Equals(null));
                if (num44)
                {
                    Loteria.Add("44. El Cantarito");
                }
                bool num45 = await dbContext.Rifas.AnyAsync(n => n.Numero45.Equals(null));
                if (num45)
                {
                    Loteria.Add("45. El Venado");
                }
                bool num46 = await dbContext.Rifas.AnyAsync(n => n.Numero46.Equals(null));
                if (num46)
                {
                    Loteria.Add("46. El Sol");
                }
                bool num47 = await dbContext.Rifas.AnyAsync(n => n.Numero47.Equals(null));
                if (num47)
                {
                    Loteria.Add("47. La Corona");
                }
                bool num48 = await dbContext.Rifas.AnyAsync(n => n.Numero48.Equals(null));
                if (num48)
                {
                    Loteria.Add("48. La Chalupa");
                }
                bool num49 = await dbContext.Rifas.AnyAsync(n => n.Numero49.Equals(null));
                if (num49)
                {
                    Loteria.Add("49. El Pino");
                }
                bool num50 = await dbContext.Rifas.AnyAsync(n => n.Numero50.Equals(null));
                if (num50)
                {
                    Loteria.Add("50. El Pescado");
                }
                bool num51 = await dbContext.Rifas.AnyAsync(n => n.Numero51.Equals(null));
                if (num51)
                {
                    Loteria.Add("51. La Palma");
                }
                bool num52 = await dbContext.Rifas.AnyAsync(n => n.Numero52.Equals(null));
                if (num52)
                {
                    Loteria.Add("52. La Maceta");
                }
                bool num53 = await dbContext.Rifas.AnyAsync(n => n.Numero53.Equals(null));
                if (num53)
                {
                    Loteria.Add("53. El Arpa");
                }
                bool num54 = await dbContext.Rifas.AnyAsync(n => n.Numero54.Equals(null));
                if (num54)
                {
                    Loteria.Add("54. la Rana");
                }
            }
            else
            {
                return NotFound("No se encuentra una rifa con ese ID");
            }

            List<LoteriaDTO> rifas = new()
            {
                new LoteriaDTO() { Id = id, CartasDisponibles = Loteria }
            };

            return mapper.Map<List<LoteriaDTO>>(rifas);
        }


        //GET PARA OBTENER AL GANADOR O GANADORES
        [HttpGet("{id:int}, {cantidad_ganadores:int}")] //Pide el id de la rifa
        public async Task<ActionResult<List<GanadoresDTO>>> Get([FromRoute] int id, int cantidad_ganadores) //Id de la rifa
        {
            int numero;
            string Carta;
            string nombre_cliente;

            string[] premios = new string[10]
            {
                "1. $50, 000", "2. $45, 000", "3. $40, 000", "4. $35, 000", "5. $30,000", "6. $25,000", "7. $20,000", "8. $15,000", "9. $10,000", "10. $5,000"
            }; 
            // 10 premios máximo (Ocupa validación)
                                            

            bool[] repetidos = new bool [54];

            for(int i = 0; i<54; i++)
            {
                repetidos[i] = false;
            }

            List<GanadoresDTO> ganadores = new();

            var exist = await dbContext.Rifas.AnyAsync(x => x.Id == id);

            if (!exist)
            {
                return NotFound("No fue encontrada la rifa");
            }

            if(cantidad_ganadores > 10 || cantidad_ganadores < 1)
            {
                return BadRequest("La cantidad de ganadores deben de estar entre 1 y 10");
            }

            string nombre_rifa = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Nombre).FirstOrDefaultAsync();

            for (int i = 0; i < cantidad_ganadores; i++)
            {
                do
                    numero = Random.Shared.Next(1, 54); //validar que no se repita 
                while (repetidos[numero-1]); //Obtener un número random (1-54) mientras sea uno repetido

                switch (numero)
                {
                    case 1:
                        Carta = "1. El Gallo";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero1).FirstOrDefaultAsync();
                        repetidos [0] = true;
                        break;
                    case 2:
                        Carta = "2. El Diablo";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero2).FirstOrDefaultAsync();
                        repetidos[1] = true;
                        break;
                    case 3:
                        Carta = "3. La Dama";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero3).FirstOrDefaultAsync();
                        repetidos[2] = true;
                        break;
                    case 4:
                        Carta = "4. El Catrin";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero4).FirstOrDefaultAsync();
                        repetidos[3] = true;
                        break;
                    case 5:
                        Carta = "5. El Paraguas";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero5).FirstOrDefaultAsync();
                        repetidos[4] = true;
                        break;
                    case 6:
                        Carta = "6. La Sirena";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero6).FirstOrDefaultAsync();
                        repetidos[5] = true;
                        break;
                    case 7:
                        Carta = "7. La Escalera";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero7).FirstOrDefaultAsync();
                        repetidos[6] = true;
                        break;
                    case 8:
                        Carta = "8. La Botella";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero8).FirstOrDefaultAsync();
                        repetidos[7] = true;
                        break;
                    case 9:
                        Carta = "9. El Barril";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero9).FirstOrDefaultAsync();
                        repetidos[8] = true;
                        break;
                    case 10:
                        Carta = "10. El Árbol";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero10).FirstOrDefaultAsync();
                        repetidos[9] = true;
                        break;
                    case 11:
                        Carta = "11. El Melón";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero11).FirstOrDefaultAsync();
                        repetidos[10] = true;
                        break;
                    case 12:
                        Carta = "12. El Valiente";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero12).FirstOrDefaultAsync();
                        repetidos[11] = true;
                        break;
                    case 13:
                        Carta = "13. El Gorrito";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero13).FirstOrDefaultAsync();
                        repetidos[12] = true;
                        break;
                    case 14:
                        Carta = "14. La Muerte";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero14).FirstOrDefaultAsync();
                        repetidos[13] = true;
                        break;
                    case 15:
                        Carta = "15. La Pera";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero15).FirstOrDefaultAsync();
                        repetidos[14] = true;
                        break;
                    case 16:
                        Carta = "16. La Bandera ";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero16).FirstOrDefaultAsync();
                        repetidos[15] = true;
                        break;
                    case 17:
                        Carta = "17. El Bandolón";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero17).FirstOrDefaultAsync();
                        repetidos[16] = true;
                        break;
                    case 18:
                        Carta = "18. El Violincello";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero18).FirstOrDefaultAsync();
                        repetidos[17] = true;
                        break;
                    case 19:
                        Carta = "19. La Garza";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero19).FirstOrDefaultAsync();
                        repetidos[18] = true;
                        break;
                    case 20:
                        Carta = "20. El Pájaro";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero20).FirstOrDefaultAsync();
                        repetidos[19] = true;
                        break;
                    case 21:
                        Carta = "21. La Mano";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero21).FirstOrDefaultAsync();
                        repetidos[20] = true;
                        break;
                    case 22:
                        Carta = "22. La Bota";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero22).FirstOrDefaultAsync();
                        repetidos[21] = true;
                        break;
                    case 23:
                        Carta = "23. La Luna";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero23).FirstOrDefaultAsync();
                        repetidos[22] = true;
                        break;
                    case 24:
                        Carta = "24. El Cotorro";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero24).FirstOrDefaultAsync();
                        repetidos[23] = true;
                        break;
                    case 25:
                        Carta = "25. El Borracho";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero25).FirstOrDefaultAsync();
                        repetidos[24] = true;
                        break;
                    case 26:
                        Carta = "26. El Negrito";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero26).FirstOrDefaultAsync();
                        repetidos[25] = true;
                        break;
                    case 27:
                        Carta = "27. El Corazón";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero27).FirstOrDefaultAsync();
                        repetidos[26] = true;
                        break;
                    case 28:
                        Carta = "28. La Sandía";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero28).FirstOrDefaultAsync();
                        repetidos[27] = true;
                        break;
                    case 29:
                        Carta = "29. El Tambor";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero29).FirstOrDefaultAsync();
                        repetidos[28] = true;
                        break;
                    case 30:
                        Carta = "30. El Camarón";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero30).FirstOrDefaultAsync();
                        repetidos[29] = true;
                        break;
                    case 31:
                        Carta = "31. Las Jaras";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero31).FirstOrDefaultAsync();
                        repetidos[30] = true;
                        break;
                    case 32:
                        Carta = "32. El Músico";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero32).FirstOrDefaultAsync();
                        repetidos[31] = true;
                        break;
                    case 33:
                        Carta = "33. La Araña";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero33).FirstOrDefaultAsync();
                        repetidos[32] = true;
                        break;
                    case 34:
                        Carta = "34. El Soldado";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero34).FirstOrDefaultAsync();
                        repetidos[33] = true;
                        break;
                    case 35:
                        Carta = "35. La Estrella";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero35).FirstOrDefaultAsync();
                        repetidos[34] = true;
                        break;
                    case 36:
                        Carta = "36. El Cazo";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero36).FirstOrDefaultAsync();
                        repetidos[35] = true;
                        break;
                    case 37:
                        Carta = "37. El Mundo";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero37).FirstOrDefaultAsync();
                        repetidos[36] = true;
                        break;
                    case 38:
                        Carta = "38. El Apache";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero38).FirstOrDefaultAsync();
                        repetidos[37] = true;
                        break;
                    case 39:
                        Carta = "39. El Nopal";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero39).FirstOrDefaultAsync();
                        repetidos[38] = true;
                        break;
                    case 40:
                        Carta = "40. El Alacrán";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero40).FirstOrDefaultAsync();
                        repetidos[39] = true;
                        break;
                    case 41:
                        Carta = "41. La Rosa";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero41).FirstOrDefaultAsync();
                        repetidos[40] = true;
                        break;
                    case 42:
                        Carta = "42. LA Calavera";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero42).FirstOrDefaultAsync();
                        repetidos[41] = true;
                        break;
                    case 43:
                        Carta = "43. La Campana";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero43).FirstOrDefaultAsync();
                        repetidos[42] = true;
                        break;
                    case 44:
                        Carta = "44. El Cantarito";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero44).FirstOrDefaultAsync();
                        repetidos[43] = true;
                        break;
                    case 45:
                        Carta = "45. El Venado";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero45).FirstOrDefaultAsync();
                        repetidos[44] = true;
                        break;
                    case 46:
                        Carta = "46. El Sol";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero46).FirstOrDefaultAsync();
                        repetidos[45] = true;
                        break;
                    case 47:
                        Carta = "47. La Corona";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero47).FirstOrDefaultAsync();
                        repetidos[46] = true;
                        break;
                    case 48:
                        Carta = "48. la Chalupa";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero48).FirstOrDefaultAsync();
                        repetidos[47] = true;
                        break;
                    case 49:
                        Carta = "49. El Pino";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero49).FirstOrDefaultAsync();
                        repetidos[48] = true;
                        break;
                    case 50:
                        Carta = "50. El Pescado";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero50).FirstOrDefaultAsync();
                        repetidos[49] = true;
                        break;
                    case 51:
                        Carta = "51. La Palma";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero51).FirstOrDefaultAsync();
                        repetidos[50] = true;
                        break;
                    case 52:
                        Carta = "52. La Maceta";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero52).FirstOrDefaultAsync();
                        repetidos[51] = true;
                        break;
                    case 53:
                        Carta = "53. El Arpa";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero53).FirstOrDefaultAsync();
                        repetidos[52] = true;
                        break;
                    case 54:
                        Carta = "54. La Rana";
                        nombre_cliente = await dbContext.Rifas.Where(x => x.Id == id).Select(n => n.Numero54).FirstOrDefaultAsync();
                        repetidos[53] = true;
                        break;
                    default: Carta = "Carta default";
                        nombre_cliente = "Nombre del Cliente default";
                        break;

                }

                ganadores.Add(new GanadoresDTO
                {
                    Id_Rifa = id, Nombre_Rifa = nombre_rifa, Carta_Rifa = Carta, Nombre_Cliente = nombre_cliente, Premio = premios[cantidad_ganadores - (i+1)]
                });
                

                
            }

            return mapper.Map<List<GanadoresDTO>>(ganadores);
        }

            //GET PARA OBTENER LOS PARTICIPANTES DE UNA RIFA (SE NECESITA TABLA CLIENTERIFA)

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreacionRifaDTO creacionRifaDto)
        {
            var rifa = mapper.Map<Rifa>(creacionRifaDto);

            dbContext.Add(rifa);
            await dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(CreacionRifaDTO rifaCreacionDTO, int id)
        {
            var exist = await dbContext.Rifas.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound();
            }

            var rifa = mapper.Map<Rifa>(rifaCreacionDTO);
            rifa.Id = id;

            dbContext.Update(rifa);
            await dbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Rifas.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("No fue encontrada la rifa");
            }

            dbContext.Remove(new Rifa()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPatch("{id:int}")]
        public async Task<ActionResult> Patch(int id, JsonPatchDocument<RifaDTO> patchDocument)
        {
            if (patchDocument == null) { return BadRequest(); }

            var rifaDB = await dbContext.Rifas.FirstOrDefaultAsync(x => x.Id == id);

            if (rifaDB == null) { return NotFound("No existe una rifa con ese ID"); }

            var rifaDTO = mapper.Map<RifaDTO>(rifaDB);

            patchDocument.ApplyTo(rifaDTO);

            var isValid = TryValidateModel(rifaDTO);

            if (!isValid)
            {
                return BadRequest(ModelState);
            }

            mapper.Map(rifaDTO, rifaDB);

            await dbContext.SaveChangesAsync();
            return NoContent();
        }



    }
    
}