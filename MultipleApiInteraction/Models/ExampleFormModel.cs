using Microsoft.AspNetCore.Components.Forms;

namespace MultipleApiInteraction.Models;

public class ExampleFormModel
{
    public IBrowserFile ExampleFile { get; set; } = default!;
}