namespace FSGen.Core

open System

module Utils =
    
    let indent (count: int) (str:string) = $"{String(' ', count * 4)}{str}" 

