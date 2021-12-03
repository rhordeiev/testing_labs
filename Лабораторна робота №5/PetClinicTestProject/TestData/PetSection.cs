using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

public class PetSection {
    public List<PetConfiguration> petList { get; }

    public PetSection(IConfiguration configuration){
        configuration.GetSection("pets").Bind(petList = new List<PetConfiguration>());
    }
}