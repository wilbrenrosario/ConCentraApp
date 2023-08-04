export class Placas {
  public id: string
  public nombres: string
  public apellidos: string
  public cedula: string
  public fechaNacimiento: string
  public tipoPlaca: string
  public tipoPersonas: string
  public tipoAutomovil: string
  public valorTotalPlaca: number

  constructor(){
      this.id = "";
      this.nombres = "";
      this.apellidos = "";
      this.cedula = "";
      this.fechaNacimiento = "";
      this.tipoPlaca = "";
      this.tipoPersonas = "";
      this.tipoAutomovil = "";
      this.valorTotalPlaca = 0;
  }
}

