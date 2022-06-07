import { Make } from "./make";

export interface Model extends Make {
  id?: number,
  name?: string,
  make?: Make
}
