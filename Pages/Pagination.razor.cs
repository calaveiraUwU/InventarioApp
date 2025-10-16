// using System.Runtime.CompilerServices;
// using InventarioApp.Models;
// using Microsoft.AspNetCore.Components;
// using System.Net.Http.Json;

// namespace InventarioApp.Pages
// {
//     public partial class Inventario
//     {private List<Item> allItems = new(); 
//         private int currentPage = 1;         
//         private int pageSize = 20;            

//         private IEnumerable<Item> PagedItems => allItems
//             .Skip((currentPage - 1) * pageSize)
//             .Take(pageSize);

//         private int TotalPages => (int)Math.Ceiling((double)allItems.Count / pageSize);

//         private void NextPage()
//         {
//             if (currentPage < TotalPages) currentPage++;
//         }

//         private void PreviousPage()
//         {
//             if (currentPage > 1) currentPage--;
//         }

//         private void GoToPage(int page)
//         {
//             if (page >= 1 && page <= TotalPages)
//                 currentPage = page;
//         }

//         private async Task CargarItemsAsync()
//         {
//             try
//             {
//                 allItems = await http.GetFromJsonAsync<List<Item>>("http://localhost:5001/api/items") ?? new();

//                 // Volvemos a la página 1 siempre que recargamos
//                 if (allItems.Any())
//                     currentPage = 1;
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"Error al cargar ítems: {ex.Message}");
//             }
//         }


//         protected override async Task OnInitializedAsync()
//         {
//             await CargarItemsAsync();
//         }
//     }
// }