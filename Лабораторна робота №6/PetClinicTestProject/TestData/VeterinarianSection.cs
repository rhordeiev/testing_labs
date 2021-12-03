using Microsoft.Extensions.Configuration;

public class VeterinarianSection {
    public VeterinarianConfiguration veterinarian { get; }

    public VeterinarianSection(IConfiguration configuration){
        configuration.GetSection("veterinarian").Bind(veterinarian = new VeterinarianConfiguration());
    }
}