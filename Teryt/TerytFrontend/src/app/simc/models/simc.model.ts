export interface SimcList {
  simcList: SIMC[]
}

export interface SIMC {
  Nazwa: string,
  WojewodztwoId: number,
  RodzGminaId: number,
  GminaId: number,
  PowiatId: number,
  RmNumer: number,
  StanNa: Date
}
