import { FC } from "react";

interface Props {
   options: Array<{ name: string; value: any; }>
   onSelect: (value: string) => void;
}

export const Select: FC<Props> = ({ onSelect, options }) => {

   const handleSelect = (event: React.ChangeEvent<HTMLSelectElement>) => {
      onSelect(event.currentTarget.value);
   }

   return (
      <select onChange={handleSelect} className="outline-none h-8 border-none app bg-transparent">
         {options.map((option, index) => (
            <option key={index} value={option.value}>{option.name}</option>
         ))}
      </select>
   )
}