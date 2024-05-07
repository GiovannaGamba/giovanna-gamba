export default function BoxListItem(prop) {
  return (
    <li key={prop.id}>
      <span className="salesOrderID">#{prop.id}</span>
      <span className="materialName">{prop.name}</span>
      {prop.quantity !== undefined && (
        <span className="quantity">Qtd: {prop.quantity} pç</span>
      )}
    </li>
  )
}
