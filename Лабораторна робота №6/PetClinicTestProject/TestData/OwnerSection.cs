using Microsoft.Extensions.Configuration;

public class OwnerSection {
    public OwnerConfiguration owner { get; }

    public OwnerSection(IConfiguration configuration){
        configuration.GetSection("owner").Bind(owner = new OwnerConfiguration());
    }
}