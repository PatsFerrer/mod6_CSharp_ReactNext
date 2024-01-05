using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DestinoCertoAPI.Models;

namespace DestinoCertoAPI.Data
{
    public class SeedDataConfiguration : IEntityTypeConfiguration<Destino>
    {
        public void Configure(EntityTypeBuilder<Destino> builder)
        {           
            builder.HasData(
                new Destino {Id=1, Nome = "Recife", Valor = 256, Descricao = "Encantadora cidade costeira no nordeste do Brasil, oferecendo praias deslumbrantes, rica herança colonial, cultura diversificada, música animada e uma cena gastronômica deliciosa.", Imagem = "https://a.cdn-hotels.com/gdcs/production165/d295/de825d07-0f3f-41e6-b41b-031791c6d729.jpg" },
                new Destino { Id = 2, Nome = "Natal", Valor = 328, Descricao = "Natal é uma acolhedora cidade no nordeste do Brasil, conhecida por suas praias paradisíacas, dunas de areia, cultura folclórica, delícias culinárias típicas e festivais animados.", Imagem = "https://visit.natal.br/assets/img/galeria3-min.jpg" },
                new Destino { Id = 3, Nome = "Curitiba", Valor = 358, Descricao = "Curitiba, capital do Paraná, é uma cidade brasileira moderna e bem planejada. Conhecida por seus parques exuberantes, arquitetura inovadora, cultura rica, gastronomia diversificada e povo acolhedor.", Imagem = "https://imgmd.net/images/v1/guia/1684234/curitiba-185-c.jpg" },
                new Destino { Id = 4, Nome = "Belo Horizonte", Valor = 339, Descricao = "Belo Horizonte, capital de Minas Gerais, encanta com sua arquitetura moderna, cultura rica e culinária deliciosa, destacando-se pelos bares e botecos típicos da região. Cidade vibrante e acolhedora.", Imagem = "https://viagemeturismo.abril.com.br/wp-content/uploads/2011/09/GettyImages-1164542668.jpg" },
                new Destino { Id = 5, Nome = "Belém", Valor = 370, Descricao = "Belém, situada na Amazônia brasileira, é uma cidade repleta de exotismo e beleza natural. Conhecida por sua rica história, gastronomia amazônica, mercados coloridos e festivais culturais envolventes.", Imagem = "https://visitbrasil.com/wp-content/uploads/2021/06/Belem-do-Para-1.jpg" },
                new Destino { Id = 6, Nome = "Fernando de Noronha", Valor = 596, Descricao = "Noronha é um paraíso tropical no Brasil, famoso por suas praias de areias douradas, águas cristalinas, vida marinha exuberante e preservação ambiental. Destino perfeito para mergulho.", Imagem = "https://www.dicasdeviagem.com/wp-content/uploads/2022/01/baia-dos-porcos-morro-noronha-scaled.jpg" },
                new Destino { Id = 7, Nome = "Jericoacoara", Valor = 459, Descricao = "Jericoacoara é um paraíso escondido no nordeste do Brasil, com dunas imponentes, praias intocadas e lagoas de águas cristalinas. Um destino paradisíaco para os amantes de natureza, esportes aquáticos e tranquilidade.", Imagem = "https://blogmaladeviagem.com.br/wp-content/uploads/2023/05/jericoacoara.jpg" },
                new Destino { Id = 8, Nome = "Alagoas", Valor = 396, Descricao = "Alagoas é um estado encantador no nordeste do Brasil, conhecido por suas praias deslumbrantes de águas mornas e coqueirais, recifes de corais, gastronomia rica e cultura folclórica cativante. Um destino tropical imperdível.", Imagem = "https://imagens.portalzuk.com.br/blog/625/63350ed3d3a1e.jpg" },
                new Destino { Id = 9, Nome = "Imperatriz", Valor = 422, Descricao = "Imperatriz é uma cidade acolhedora no estado do Maranhão, Brasil. Destaca-se por sua rica cultura, festivais animados, culinária típica, parques arborizados e proximidade com belezas naturais como rios e cachoeiras.", Imagem = "https://blog.123milhas.com/wp-content/uploads/2023/01/onde-se-hospedar-em-imperatriz-hoteis-e-pousadas-conexao123-2.jpg" }

            );
        }
    }

    public class SeedDataConfigurationCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasData(
                new Cliente { Id = 1, Nome = "Irineu Júnior", Senha = "123", Email = "iri.jr@gmail.com", Cpf = "789.674.789-98", Telefone = "9 2658-5236", DataNascimento=DateTime.Parse("1985-03-13") },
                new Cliente { Id = 2, Nome = "Daenerys Targaryen", Senha = "843", Email = "maedragoes@com", Cpf = "123.654.789-98", Telefone = "9 8745-4789", DataNascimento = DateTime.Parse("1996-05-23") },
                new Cliente { Id = 3, Nome = "Carol Denvers", Senha = "789", Email = "cap.marvel@gmail.com", Cpf = "987.654.789-98", Telefone = "9 9854-1425", DataNascimento = DateTime.Parse("1979-07-10") },
                new Cliente { Id = 4, Nome = "Steve Rogers", Senha = "655", Email = "cap.america@gmail.com", Cpf = "967.257.146-23", Telefone = "9 8945-3576", DataNascimento = DateTime.Parse("1914-11-15") }

            );
        }
    }
}
