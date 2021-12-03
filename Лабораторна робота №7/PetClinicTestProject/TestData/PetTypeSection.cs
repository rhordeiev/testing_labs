using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

public class PetTypeSection {
    public List<PetTypeConfiguration> petTypesList { get; }

    public PetTypeSection(IConfiguration configuration){
        configuration.GetSection("petTypes").Bind(petTypesList = new List<PetTypeConfiguration>());
    }
}