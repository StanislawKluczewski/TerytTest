export interface UlicList {
  ulicList: Ulic[]
}

export interface Ulic {
  WojewodztwoId: number,
  PowiatId: number,
  GminaId: number,
  Cecha: string,
  Nazwa1: string,
  Nazwa2: string,
  NazwaSimc: string,
  StanNa: Date
}
