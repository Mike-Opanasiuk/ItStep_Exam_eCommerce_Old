import { forwardRef, ReactNode } from 'react';

interface Props {
   onFinish: (values: {
      [key: string]: any;
   }) => void;
   children: ReactNode;
}

export const Form = forwardRef<HTMLFormElement, Props>(({ children, onFinish }, ref) => {

   const handleSubmitForm = (event: React.FormEvent<HTMLFormElement>) => {

      event.preventDefault();

      // Declare variable for values to return at the end
      const values: { [key: string]: any } = {};

      for (let i = 0; i < event.currentTarget.elements.length; i++) {
         const element = event.currentTarget.elements[i] as HTMLInputElement;

         // input value of attribute 'name'
         const name = element.name;

         if (!name) {
            continue;
         }

         const type = element.type;

         if (type === "checbox") { // type="checkbox"
            values[name] = element.checked;
         } else {
            values[name] = element.value;
         }
      }

      onFinish(values);
   }

   return <form ref={ref} onSubmit={handleSubmitForm}>{children}</form>;
});